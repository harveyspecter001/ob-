using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007C3 RID: 1987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmoteMassivePlayEvent : IMessage<EmoteMassivePlayEvent>, IMessage, IEquatable<EmoteMassivePlayEvent>, IDeepCloneable<EmoteMassivePlayEvent>, IBufferMessage
	{
		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06006164 RID: 24932 RVA: 0x00220E7C File Offset: 0x0021F07C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<EmoteMassivePlayEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06006165 RID: 24933 RVA: 0x00220E8C File Offset: 0x0021F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x00220E9C File Offset: 0x0021F09C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x00220EAC File Offset: 0x0021F0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteMassivePlayEvent()
		{
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x00220EBC File Offset: 0x0021F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteMassivePlayEvent(EmoteMassivePlayEvent other)
		{
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x00220ECC File Offset: 0x0021F0CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteMassivePlayEvent Clone()
		{
			return null;
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x0600616A RID: 24938 RVA: 0x00220EDC File Offset: 0x0021F0DC
		// (set) Token: 0x0600616B RID: 24939 RVA: 0x00220EEC File Offset: 0x0021F0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EmoteId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x00220EFC File Offset: 0x0021F0FC
		// (set) Token: 0x0600616D RID: 24941 RVA: 0x00220F0C File Offset: 0x0021F10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EmoteStartTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x00220F1C File Offset: 0x0021F11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> ActorsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00220F2C File Offset: 0x0021F12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x00220F3C File Offset: 0x0021F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmoteMassivePlayEvent other)
		{
			return true;
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00220F4C File Offset: 0x0021F14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00220F5C File Offset: 0x0021F15C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00220F6C File Offset: 0x0021F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x00220F7C File Offset: 0x0021F17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x00220F8C File Offset: 0x0021F18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x00220F9C File Offset: 0x0021F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmoteMassivePlayEvent other)
		{
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x00220FAC File Offset: 0x0021F1AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x00220FBC File Offset: 0x0021F1BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x00220FCC File Offset: 0x0021F1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmoteMassivePlayEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					EmoteMassivePlayEvent._repeated_actorsId_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(26U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 2;
					break;
				case 1:
					EmoteMassivePlayEvent._parser = new MessageParser<EmoteMassivePlayEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x002210B8 File Offset: 0x0021F2B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xT9swfOFRKl6E1wfjXtk()
		{
			return true;
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x002210C0 File Offset: 0x0021F2C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmoteMassivePlayEvent guDlsMOFOVujgfk3ivOy()
		{
			return null;
		}

		// Token: 0x0400223A RID: 8762
		private static readonly MessageParser<EmoteMassivePlayEvent> _parser;

		// Token: 0x0400223B RID: 8763
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400223C RID: 8764
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x0400223D RID: 8765
		private int emoteId_;

		// Token: 0x0400223E RID: 8766
		public const int EmoteStartTimeFieldNumber = 2;

		// Token: 0x0400223F RID: 8767
		private long emoteStartTime_;

		// Token: 0x04002240 RID: 8768
		public const int ActorsIdFieldNumber = 3;

		// Token: 0x04002241 RID: 8769
		private static readonly FieldCodec<long> _repeated_actorsId_codec;

		// Token: 0x04002242 RID: 8770
		private readonly RepeatedField<long> actorsId_;

		// Token: 0x04002243 RID: 8771
		internal static EmoteMassivePlayEvent DrQ12VOF3SNMQtX67cbJ;
	}
}

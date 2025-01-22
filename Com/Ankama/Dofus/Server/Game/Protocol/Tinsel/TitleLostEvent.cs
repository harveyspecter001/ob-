using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x0200006F RID: 111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TitleLostEvent : IMessage<TitleLostEvent>, IMessage, IEquatable<TitleLostEvent>, IDeepCloneable<TitleLostEvent>, IBufferMessage
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x001891AC File Offset: 0x001873AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TitleLostEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x001891BC File Offset: 0x001873BC
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x001891CC File Offset: 0x001873CC
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

		// Token: 0x06000454 RID: 1108 RVA: 0x001891DC File Offset: 0x001873DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleLostEvent()
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x001891EC File Offset: 0x001873EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleLostEvent(TitleLostEvent other)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x001891FC File Offset: 0x001873FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitleLostEvent Clone()
		{
			return null;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0018920C File Offset: 0x0018740C
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0018921C File Offset: 0x0018741C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TitleId
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

		// Token: 0x06000459 RID: 1113 RVA: 0x0018922C File Offset: 0x0018742C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0018923C File Offset: 0x0018743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TitleLostEvent other)
		{
			return true;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0018924C File Offset: 0x0018744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0018925C File Offset: 0x0018745C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0018926C File Offset: 0x0018746C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0018927C File Offset: 0x0018747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0018928C File Offset: 0x0018748C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0018929C File Offset: 0x0018749C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TitleLostEvent other)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x001892AC File Offset: 0x001874AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x001892BC File Offset: 0x001874BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x001892CC File Offset: 0x001874CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TitleLostEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					TitleLostEvent._parser = new MessageParser<TitleLostEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00189398 File Offset: 0x00187598
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LMbNv8OK9eaSGrqB7UV6()
		{
			return true;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x001893A0 File Offset: 0x001875A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TitleLostEvent QDjEyuOK2bYtTNV21MvK()
		{
			return null;
		}

		// Token: 0x040001BE RID: 446
		private static readonly MessageParser<TitleLostEvent> _parser;

		// Token: 0x040001BF RID: 447
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001C0 RID: 448
		public const int TitleIdFieldNumber = 1;

		// Token: 0x040001C1 RID: 449
		private int titleId_;

		// Token: 0x040001C2 RID: 450
		private static TitleLostEvent KF7Lx8OKdBB2QhoObBFF;
	}
}

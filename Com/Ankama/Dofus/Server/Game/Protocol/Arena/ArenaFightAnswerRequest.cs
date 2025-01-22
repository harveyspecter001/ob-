using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C0E RID: 3086
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaFightAnswerRequest : IMessage<ArenaFightAnswerRequest>, IMessage, IEquatable<ArenaFightAnswerRequest>, IDeepCloneable<ArenaFightAnswerRequest>, IBufferMessage
	{
		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06009445 RID: 37957 RVA: 0x00275F7C File Offset: 0x0027417C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ArenaFightAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06009446 RID: 37958 RVA: 0x00275F8C File Offset: 0x0027418C
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

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06009447 RID: 37959 RVA: 0x00275F9C File Offset: 0x0027419C
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

		// Token: 0x06009448 RID: 37960 RVA: 0x00275FAC File Offset: 0x002741AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightAnswerRequest()
		{
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x00275FBC File Offset: 0x002741BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightAnswerRequest(ArenaFightAnswerRequest other)
		{
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x00275FCC File Offset: 0x002741CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFightAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x0600944B RID: 37963 RVA: 0x00275FDC File Offset: 0x002741DC
		// (set) Token: 0x0600944C RID: 37964 RVA: 0x00275FEC File Offset: 0x002741EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accept
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x00275FFC File Offset: 0x002741FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x0027600C File Offset: 0x0027420C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaFightAnswerRequest other)
		{
			return true;
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x0027601C File Offset: 0x0027421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x0027602C File Offset: 0x0027422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x0027603C File Offset: 0x0027423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x0027604C File Offset: 0x0027424C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x0027605C File Offset: 0x0027425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009454 RID: 37972 RVA: 0x0027606C File Offset: 0x0027426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaFightAnswerRequest other)
		{
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x0027607C File Offset: 0x0027427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x0027608C File Offset: 0x0027428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x0027609C File Offset: 0x0027429C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaFightAnswerRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ArenaFightAnswerRequest._parser = new MessageParser<ArenaFightAnswerRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x00276194 File Offset: 0x00274394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hWnGlGJX9M1TPeMBJjwl()
		{
			return true;
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x0027619C File Offset: 0x0027439C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaFightAnswerRequest wncBqRJX2KTY6El23UvI()
		{
			return null;
		}

		// Token: 0x04003731 RID: 14129
		private static readonly MessageParser<ArenaFightAnswerRequest> _parser;

		// Token: 0x04003732 RID: 14130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003733 RID: 14131
		public const int AcceptFieldNumber = 1;

		// Token: 0x04003734 RID: 14132
		private bool accept_;

		// Token: 0x04003735 RID: 14133
		private static ArenaFightAnswerRequest u72nROJXd6Q2H9pvHgIB;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000477 RID: 1143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagEnterRequest : IMessage<HavenBagEnterRequest>, IMessage, IEquatable<HavenBagEnterRequest>, IDeepCloneable<HavenBagEnterRequest>, IBufferMessage
	{
		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x001DE57C File Offset: 0x001DC77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagEnterRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x001DE58C File Offset: 0x001DC78C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x001DE59C File Offset: 0x001DC79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x001DE5AC File Offset: 0x001DC7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEnterRequest()
		{
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x001DE5BC File Offset: 0x001DC7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEnterRequest(HavenBagEnterRequest other)
		{
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x001DE5CC File Offset: 0x001DC7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEnterRequest Clone()
		{
			return null;
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x001DE5DC File Offset: 0x001DC7DC
		// (set) Token: 0x060036BC RID: 14012 RVA: 0x001DE5EC File Offset: 0x001DC7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Owner
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

		// Token: 0x060036BD RID: 14013 RVA: 0x001DE5FC File Offset: 0x001DC7FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x001DE60C File Offset: 0x001DC80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagEnterRequest other)
		{
			return true;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x001DE61C File Offset: 0x001DC81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x001DE62C File Offset: 0x001DC82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x001DE63C File Offset: 0x001DC83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x001DE64C File Offset: 0x001DC84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x001DE65C File Offset: 0x001DC85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x001DE66C File Offset: 0x001DC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagEnterRequest other)
		{
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x001DE67C File Offset: 0x001DC87C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x001DE68C File Offset: 0x001DC88C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x001DE69C File Offset: 0x001DC89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagEnterRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					HavenBagEnterRequest._parser = new MessageParser<HavenBagEnterRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x001DE780 File Offset: 0x001DC980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool op2A4WOtPGUk30AGC2Da()
		{
			return true;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x001DE788 File Offset: 0x001DC988
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagEnterRequest k9Yum3OtS1GJbSNPtvj6()
		{
			return null;
		}

		// Token: 0x0400133B RID: 4923
		private static readonly MessageParser<HavenBagEnterRequest> _parser;

		// Token: 0x0400133C RID: 4924
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400133D RID: 4925
		public const int OwnerFieldNumber = 1;

		// Token: 0x0400133E RID: 4926
		private long owner_;

		// Token: 0x0400133F RID: 4927
		private static HavenBagEnterRequest Yc00j1OtibfcZJ3mZwnu;
	}
}

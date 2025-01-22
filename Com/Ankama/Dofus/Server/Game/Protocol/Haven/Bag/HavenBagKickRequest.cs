using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000489 RID: 1161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagKickRequest : IMessage<HavenBagKickRequest>, IMessage, IEquatable<HavenBagKickRequest>, IDeepCloneable<HavenBagKickRequest>, IBufferMessage
	{
		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x001DF72C File Offset: 0x001DD92C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x001DF73C File Offset: 0x001DD93C
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

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x001DF74C File Offset: 0x001DD94C
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

		// Token: 0x06003797 RID: 14231 RVA: 0x001DF75C File Offset: 0x001DD95C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagKickRequest()
		{
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x001DF76C File Offset: 0x001DD96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagKickRequest(HavenBagKickRequest other)
		{
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x001DF77C File Offset: 0x001DD97C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagKickRequest Clone()
		{
			return null;
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x001DF78C File Offset: 0x001DD98C
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x001DF79C File Offset: 0x001DD99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GuestId
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

		// Token: 0x0600379C RID: 14236 RVA: 0x001DF7AC File Offset: 0x001DD9AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x001DF7BC File Offset: 0x001DD9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagKickRequest other)
		{
			return true;
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x001DF7CC File Offset: 0x001DD9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x001DF7DC File Offset: 0x001DD9DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x001DF7EC File Offset: 0x001DD9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x001DF7FC File Offset: 0x001DD9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x001DF80C File Offset: 0x001DDA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x001DF81C File Offset: 0x001DDA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagKickRequest other)
		{
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x001DF82C File Offset: 0x001DDA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x001DF83C File Offset: 0x001DDA3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x001DF84C File Offset: 0x001DDA4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagKickRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					HavenBagKickRequest._parser = new MessageParser<HavenBagKickRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x001DF918 File Offset: 0x001DDB18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KwXthGOwNwjoqA3lOrvf()
		{
			return true;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x001DF920 File Offset: 0x001DDB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagKickRequest F7EGQkOwxtIVdH7nAujP()
		{
			return null;
		}

		// Token: 0x04001371 RID: 4977
		private static readonly MessageParser<HavenBagKickRequest> _parser;

		// Token: 0x04001372 RID: 4978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001373 RID: 4979
		public const int GuestIdFieldNumber = 1;

		// Token: 0x04001374 RID: 4980
		private long guestId_;

		// Token: 0x04001375 RID: 4981
		internal static HavenBagKickRequest nYH46dOwXMWTULbrp1km;
	}
}

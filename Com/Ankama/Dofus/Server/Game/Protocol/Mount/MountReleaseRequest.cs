using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200035B RID: 859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountReleaseRequest : IMessage<MountReleaseRequest>, IMessage, IEquatable<MountReleaseRequest>, IDeepCloneable<MountReleaseRequest>, IBufferMessage
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x001C6538 File Offset: 0x001C4738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountReleaseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x001C6548 File Offset: 0x001C4748
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x001C6558 File Offset: 0x001C4758
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

		// Token: 0x06002853 RID: 10323 RVA: 0x001C6568 File Offset: 0x001C4768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountReleaseRequest()
		{
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x001C6578 File Offset: 0x001C4778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountReleaseRequest(MountReleaseRequest other)
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x001C6588 File Offset: 0x001C4788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountReleaseRequest Clone()
		{
			return null;
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x001C6598 File Offset: 0x001C4798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x001C65A8 File Offset: 0x001C47A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountReleaseRequest other)
		{
			return true;
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x001C65B8 File Offset: 0x001C47B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x001C65C8 File Offset: 0x001C47C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x001C65D8 File Offset: 0x001C47D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x001C65E8 File Offset: 0x001C47E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x001C65F8 File Offset: 0x001C47F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x001C6608 File Offset: 0x001C4808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountReleaseRequest other)
		{
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x001C6618 File Offset: 0x001C4818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x001C6628 File Offset: 0x001C4828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x001C6638 File Offset: 0x001C4838
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountReleaseRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					MountReleaseRequest._parser = new MessageParser<MountReleaseRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x001C671C File Offset: 0x001C491C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dwMw2tOhrgsd6Quuvh7V()
		{
			return true;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x001C6724 File Offset: 0x001C4924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountReleaseRequest KcmPiPOhVM7AAfAx3JkC()
		{
			return null;
		}

		// Token: 0x04000E58 RID: 3672
		private static readonly MessageParser<MountReleaseRequest> _parser;

		// Token: 0x04000E59 RID: 3673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E5A RID: 3674
		internal static MountReleaseRequest HQoNIyOhhL7bYtvg8jkI;
	}
}

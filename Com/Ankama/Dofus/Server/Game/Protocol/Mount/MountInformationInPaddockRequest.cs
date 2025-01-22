using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200036B RID: 875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountInformationInPaddockRequest : IMessage<MountInformationInPaddockRequest>, IMessage, IEquatable<MountInformationInPaddockRequest>, IDeepCloneable<MountInformationInPaddockRequest>, IBufferMessage
	{
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x001C73D0 File Offset: 0x001C55D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountInformationInPaddockRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x001C73E0 File Offset: 0x001C55E0
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

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x001C73F0 File Offset: 0x001C55F0
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

		// Token: 0x0600290E RID: 10510 RVA: 0x001C7400 File Offset: 0x001C5600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountInformationInPaddockRequest()
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x001C7410 File Offset: 0x001C5610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountInformationInPaddockRequest(MountInformationInPaddockRequest other)
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x001C7420 File Offset: 0x001C5620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountInformationInPaddockRequest Clone()
		{
			return null;
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x001C7430 File Offset: 0x001C5630
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x001C7440 File Offset: 0x001C5640
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MountId
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

		// Token: 0x06002913 RID: 10515 RVA: 0x001C7450 File Offset: 0x001C5650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x001C7460 File Offset: 0x001C5660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountInformationInPaddockRequest other)
		{
			return true;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x001C7470 File Offset: 0x001C5670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x001C7480 File Offset: 0x001C5680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x001C7490 File Offset: 0x001C5690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x001C74A0 File Offset: 0x001C56A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x001C74B0 File Offset: 0x001C56B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x001C74C0 File Offset: 0x001C56C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountInformationInPaddockRequest other)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x001C74D0 File Offset: 0x001C56D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x001C74E0 File Offset: 0x001C56E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x001C74F0 File Offset: 0x001C56F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountInformationInPaddockRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MountInformationInPaddockRequest._parser = new MessageParser<MountInformationInPaddockRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x001C75E8 File Offset: 0x001C57E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JuYtL4OhqDbH2VBNwN98()
		{
			return true;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x001C75F0 File Offset: 0x001C57F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountInformationInPaddockRequest sUhiqUOhFpa40vXV5DIU()
		{
			return null;
		}

		// Token: 0x04000E92 RID: 3730
		private static readonly MessageParser<MountInformationInPaddockRequest> _parser;

		// Token: 0x04000E93 RID: 3731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E94 RID: 3732
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000E95 RID: 3733
		private int mountId_;

		// Token: 0x04000E96 RID: 3734
		private static MountInformationInPaddockRequest skl3s5OhZjlPeCHbedVc;
	}
}

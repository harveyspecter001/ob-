using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006BF RID: 1727
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMapRequest : IMessage<FightMapRequest>, IMessage, IEquatable<FightMapRequest>, IDeepCloneable<FightMapRequest>, IBufferMessage
	{
		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x0020AF9C File Offset: 0x0020919C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightMapRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x0020AFAC File Offset: 0x002091AC
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

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06005471 RID: 21617 RVA: 0x0020AFBC File Offset: 0x002091BC
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

		// Token: 0x06005472 RID: 21618 RVA: 0x0020AFCC File Offset: 0x002091CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapRequest()
		{
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x0020AFDC File Offset: 0x002091DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapRequest(FightMapRequest other)
		{
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x0020AFEC File Offset: 0x002091EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapRequest Clone()
		{
			return null;
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x0020AFFC File Offset: 0x002091FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x0020B00C File Offset: 0x0020920C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightMapRequest other)
		{
			return true;
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x0020B01C File Offset: 0x0020921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x0020B02C File Offset: 0x0020922C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0020B03C File Offset: 0x0020923C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x0020B04C File Offset: 0x0020924C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0020B05C File Offset: 0x0020925C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0020B06C File Offset: 0x0020926C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightMapRequest other)
		{
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0020B07C File Offset: 0x0020927C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x0020B08C File Offset: 0x0020928C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0020B09C File Offset: 0x0020929C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightMapRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					FightMapRequest._parser = new MessageParser<FightMapRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0020B180 File Offset: 0x00209380
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mNxpIkOShM9BmAuboOSc()
		{
			return true;
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x0020B188 File Offset: 0x00209388
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightMapRequest DtenPtOSrnc0uHfidkSI()
		{
			return null;
		}

		// Token: 0x04001DBC RID: 7612
		private static readonly MessageParser<FightMapRequest> _parser;

		// Token: 0x04001DBD RID: 7613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DBE RID: 7614
		private static FightMapRequest mvZQMNOSWVQGEEaTiEGx;
	}
}
